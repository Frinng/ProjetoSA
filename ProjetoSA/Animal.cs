namespace ProjetoSA;

public class Animal {
    public class AnimalMaternidade {
        public string brinco_identificador { get; set; }
        public int idade_meses { get; set; }
        public decimal peso_kg { get; set; }
        public string raca { get; set; }
    }
    public class AnimalEngorda {
        public string brinco_identificador { get; set; }
        public string sexo_animal { get; set; }
        public int idade_meses { get; set; }
        public decimal peso_kg { get; set; }
    }
    public class AnimalQuarentena {
        public string brinco_identificador { get; set; }
        public string sexo_animal { get; set; }
        public int idade_meses { get; set; }
        public string status { get; set; }
    }
}