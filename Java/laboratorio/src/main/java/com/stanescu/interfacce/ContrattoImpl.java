package com.stanescu.interfacce;

public class ContrattoImpl implements Contratto {

	@Override
	public void regola1() {
		System.out.println("Ho rispettato la regola 1");
	}
	
	public void miaRegolaCustom() {
		System.out.println("Fatti miei");
	}

}
