namespace SOLID.SRP.Solucao
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            //Apenas um exemplo, n�o � uma valida��o real.
            return cpf.Length == 11;
        }
    }
}