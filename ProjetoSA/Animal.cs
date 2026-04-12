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
    public class AnimalGeral {
        public string tag { get; set; }
        public string sexo { get; set; }
        public double peso { get; set; }
        public string eh_matriz { get; set; }
        public string em_engorda { get; set; }
        public string na_maternidade { get; set; }
        public string em_quarentena { get; set; }
    }
    public class Produto {
        public int id_produto { get; set; }
        public string nome_produto { get; set; }
        public int Qnt_Produto { get; set; }
        public DateTime dt_fabricacao { get; set; }
        public DateTime dt_validade { get; set; }
    }
    public class ContratoDTO {
        public int id_contrato { get; set; }
        public decimal valor_total { get; set; }
        public DateTime data_vencimento { get; set; }
        public string status_contrato { get; set; }
        public string termos_clausulas { get; set; }
    }
}