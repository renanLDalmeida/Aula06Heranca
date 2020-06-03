namespace Encapsulamento
{
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool ValidarCnpj(){
            if (cnpj != null){
                return true;
            }
            else{
                return false;
            }
        }
    }
}