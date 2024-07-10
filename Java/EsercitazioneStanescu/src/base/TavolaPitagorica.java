package base;

public class TavolaPitagorica {

	public static void main(String[] args) {
		
		final int righe = 10;
		final int colonne = 10;
		
		for (int i = 1; i <= righe; i++) {
			for (int j = 1; j <= colonne; j++) {
//				if(i * j % 2 == 0)
				System.out.print(i*j + "\t");
			}
			
			System.out.println();
		}

	}

}
