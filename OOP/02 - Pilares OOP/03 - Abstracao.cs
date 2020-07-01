namespace OOP
{
    //abstract poíbe que esta classe seja instanciada, ela só pode ser herdada
    //Abastração é a base para  polimorfismo e o encapsulamento
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar(); //métodos abstratos obrigatoriamente precisam ser implementados
        public abstract void Desligar();

        public virtual void Testar() //Virtual - Possui implementação e pode ser sobrescrito pela classe que herda(Não obrigatoriamente deve ser sobreescrito)
        {
            // teste do equipamento
        }
    }
}