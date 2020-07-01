namespace OOP
{
    // Poli-morfismo
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        public CafeteiraEspressa()
            : base("Padrao", 220) {  }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Testar() //Método virtual na classe base, pode ou não ser sobrescrito(não é obrigatório)
        {
            // teste de cafeteira
        }

        public override void Ligar()//Método Abstract na classe base, é obrigatório sua implementação
        {
            // Verificar recipiente de agua
        }

        public override void Desligar()
        {
            // Resfriar aquecedor
        }
    }
}