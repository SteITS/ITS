package Cani;

public class CaneGrande extends Cane {

	public String ciboSpeciale;
	
	public CaneGrande(String nome, String razza, int eta) {
		super(nome, "grande", razza, eta);
		this.ciboSpeciale = "Scatolette giganti";
	}
	
	@Override
	public void mangia(int num) {
		System.out.println(ciboSpeciale + "" + num);
		System.out.println("munch munch");
	}

}
