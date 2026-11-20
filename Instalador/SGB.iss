; Instalador del Sistema de Gestión de Biblioteca (SGB)
; Requisito previo: publicar la UI self-contained para win-x64 (ver PublishDir).
;   dotnet publish SGB\UI\UI.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=false
; La base de datos no la crea el instalador: la crea el sistema en su primer inicio con los scripts de BD_SQL.

#define AppName "SGB"
#define AppNombreLargo "Sistema de Gestión de Biblioteca"
#define AppVersion "1.0.0"
#define AppExe "UI.exe"
#define PublishDir "..\SGB\UI\bin\Release\net8.0-windows\win-x64\publish"

[Setup]
; No cambiar el AppId entre versiones: si cambia, Windows registra otra instalación en vez de actualizar
AppId={{F33082B3-6207-412A-ADC6-79740BF543E0}
AppName={#AppNombreLargo}
AppVersion={#AppVersion}
AppPublisher=Iñaki Farías - UAI
DefaultDirName={autopf}\{#AppName}
DefaultGroupName={#AppName}
DisableProgramGroupPage=yes
; Por usuario y sin UAC: {autopf} = %LOCALAPPDATA%\Programs, donde el .env se puede editar sin admin
PrivilegesRequired=lowest
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
OutputDir=Output
OutputBaseFilename=Setup_SGB_{#AppVersion}
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
UninstallDisplayIcon={app}\{#AppExe}
UninstallDisplayName={#AppNombreLargo}
CloseApplications=yes

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
; Publicación completa (runtime de .NET, Idiomas y BD_SQL incluidos), sin el .env de desarrollo ni símbolos
Source: "{#PublishDir}\*"; DestDir: "{app}"; Excludes: ".env,*.pdb"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\{#AppNombreLargo}"; Filename: "{app}\{#AppExe}"
Name: "{autoprograms}\Configurar conexión del SGB"; Filename: "{win}\notepad.exe"; Parameters: """{app}\.env"""
Name: "{autodesktop}\{#AppNombreLargo}"; Filename: "{app}\{#AppExe}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#AppExe}"; Description: "{cm:LaunchProgram,{#AppNombreLargo}}"; Flags: nowait postinstall skipifsilent

[UninstallDelete]
; El .env lo escribe el asistente, no la sección [Files]: se borra a mano al desinstalar
Type: files; Name: "{app}\.env"

[Code]
var
  PaginaConexion: TInputQueryWizardPage;

procedure InitializeWizard;
begin
  PaginaConexion := CreateInputQueryPage(wpSelectDir,
    'Conexión a SQL Server',
    'Indicá la instancia de SQL Server de esta PC.',
    'El sistema se conecta con autenticación de Windows y crea la base bd_sgb, con datos de prueba, la primera vez que se abre.' + #13#10 + #13#10 +
    'Ejemplos:' + #13#10 +
    '   .\SQLEXPRESS              SQL Server Express' + #13#10 +
    '   localhost                 instancia por defecto' + #13#10 +
    '   (localdb)\MSSQLLocalDB    LocalDB' + #13#10 + #13#10 +
    'Se puede cambiar después desde el acceso directo "Configurar conexión del SGB".');
  PaginaConexion.Add('Instancia:', False);
  PaginaConexion.Values[0] := '.\SQLEXPRESS';
end;

// Solo caracteres válidos en un nombre de instancia: evita que se inyecten otras opciones en la cadena (;, =, comillas)
function InstanciaValida(const Valor: String): Boolean;
var
  I: Integer;
  C: Char;
begin
  Result := Length(Valor) > 0;
  for I := 1 to Length(Valor) do
  begin
    C := Valor[I];
    if not (((C >= 'A') and (C <= 'Z')) or ((C >= 'a') and (C <= 'z')) or ((C >= '0') and (C <= '9')) or
            (C = '.') or (C = '\') or (C = '_') or (C = '-') or (C = '(') or (C = ')') or (C = ',')) then
      Result := False;
  end;
end;

function NextButtonClick(CurPageID: Integer): Boolean;
begin
  Result := True;
  if CurPageID = PaginaConexion.ID then
  begin
    PaginaConexion.Values[0] := Trim(PaginaConexion.Values[0]);
    if not InstanciaValida(PaginaConexion.Values[0]) then
    begin
      MsgBox('La instancia solo puede contener letras, números y los caracteres . \ _ - ( ) ,', mbError, MB_OK);
      Result := False;
    end;
  end;
end;

// Al terminar de copiar, escribe el .env junto al ejecutable (lo lee Conexion_351FI)
procedure CurStepChanged(CurStep: TSetupStep);
var
  Contenido: String;
begin
  if CurStep = ssPostInstall then
  begin
    Contenido :=
      '# Conexion a SQL Server con autenticacion de Windows.' + #13#10 +
      '# Cambiar solo Server= segun la instancia de esta PC. No cambiar Database=.' + #13#10 +
      'DB_CONNECTION=''Server=' + PaginaConexion.Values[0] + ';Database=bd_sgb;Trusted_Connection=True;TrustServerCertificate=True''' + #13#10;
    if not SaveStringToFile(ExpandConstant('{app}\.env'), Contenido, False) then
      MsgBox('No se pudo escribir el archivo de conexión ' + ExpandConstant('{app}\.env') + '.', mbError, MB_OK);
  end;
end;
