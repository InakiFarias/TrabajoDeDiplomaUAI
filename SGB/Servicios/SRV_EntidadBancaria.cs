namespace Servicio
{
    // Servicio que se comunica con la entidad bancaria para solicitar la autorización de los pagos con tarjeta.
    // No almacena los datos de la tarjeta: el número solo se usa durante la solicitud de autorización.
    public class SRV_EntidadBancaria
    {
        // La entidad bancaria se simula: autoriza el pago si el número de tarjeta es válido (algoritmo de Luhn)
        public bool SolicitarAutorizacion(string numeroTarjeta, decimal monto)
        {
            if (monto <= 0) return false;
            return NumeroValido(numeroTarjeta);
        }

        private bool NumeroValido(string numeroTarjeta)
        {
            int suma = 0;
            bool duplicar = false;
            for (int i = numeroTarjeta.Length - 1; i >= 0; i--)
            {
                int digito = numeroTarjeta[i] - '0';
                if (duplicar)
                {
                    digito *= 2;
                    if (digito > 9) digito -= 9;
                }
                suma += digito;
                duplicar = !duplicar;
            }
            return suma % 10 == 0;
        }
    }
}
