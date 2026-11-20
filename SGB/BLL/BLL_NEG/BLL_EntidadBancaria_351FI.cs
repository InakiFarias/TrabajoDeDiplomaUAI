namespace BLL.BLL_NEG
{
    // Simula la autorización del pago con tarjeta por parte de la entidad bancaria (CU-NEG-8)
    public class BLL_EntidadBancaria_351FI
    {
        // El pago se aprueba si el total es mayor a cero y el número de tarjeta es válido (algoritmo de Luhn)
        public bool Autorizar_351FI(string numeroTarjeta_351FI, decimal total_351FI)
        {
            if (total_351FI <= 0) return false;

            int suma = 0;
            bool duplicar = false;
            for (int i = numeroTarjeta_351FI.Length - 1; i >= 0; i--)
            {
                int digito = numeroTarjeta_351FI[i] - '0';
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
