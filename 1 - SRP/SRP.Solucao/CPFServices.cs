namespace SOLID.SRP.Solucao
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            //Apenas um exemplo, não é uma validação real.
            return cpf.Length == 11;
        }
    }
}