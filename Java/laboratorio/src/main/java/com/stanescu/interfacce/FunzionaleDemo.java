package com.stanescu.interfacce;

import java.util.IntSummaryStatistics;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class FunzionaleDemo {
	public static void main(String[] args) {
		Stream<String> of = Stream.of("do","re","mi","fa");
		
		of
		.filter(nota -> nota.endsWith("a"))
		.forEach(n -> System.out.println(n));
		
		IntStream voti = IntStream.of(24,25,26,28,18,15,19,25,28,30,30,16);
		
		IntSummaryStatistics summaryStatistics = voti.summaryStatistics();
		
		System.out.println(summaryStatistics);
	}
}
