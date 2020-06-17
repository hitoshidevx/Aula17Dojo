namespace Aula17Dojo
{
    public class IngressoVIP : Ingressso
    {
        //MostrarValorVip() 
        // 

        public float ValorAdicional { get; set; }

        public void MostrarValorVip(){
            float resultadoVip = ValorAdicional + Valor;

            System.Console.WriteLine($"O valor do ingresso VIP é de R$ {");

        }
    }
}