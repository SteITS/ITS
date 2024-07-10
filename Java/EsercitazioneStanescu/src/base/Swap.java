package base;

import java.util.Arrays;

public class Swap {

	public static void main(String[] args) {
		
		int[] voti = {25,21,30,24,18};
		Arrays.sort(voti);
		for (int i = 0; i < voti.length; i++) {
			System.out.println(voti[i]);
		}
		Arrays.sort(voti);
		System.out.println(voti);
	}

	private static int[] swap(int[] a) {
		
		//int[] scambiati = new int[2];
		int temp = a[1];
		a[1] = a[0];
		a[0] = temp;
		return a;
		
	}

}
