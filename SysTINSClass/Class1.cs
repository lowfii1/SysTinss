namespace SysTINSClass
{
    public class Class1
    {
        public int Id {  get; set; }// pode receber valor e passar valor 
        // XML Docs
        /// <summary>
        ///  Calcula o valor das parcelas pela divisão do montante pelo numero de parcelas respeitando as RNs 25 e 26
        /// </summary>
        /// <param name="valor">montante a ser parcelado</param>
        /// <param name="nparc">o número de parcelas (de acordo a RN25)</param>
        /// <returns>o valor de cada parcela ( de acordo com a RN26)</returns>
        public double Calcular (double valor, int nparc) 
        { 
        return valor / nparc;
        }// não retorna valor o void
    }
}
