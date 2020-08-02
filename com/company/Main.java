package com.company;

import java.util.Scanner;

public class Main {

    public static void main(final String[] args) {
        final Scanner sc = new Scanner(System.in);
        long Sum = 0;
        int Count = 0;
        double Avg = 0.0;
        long Big = Long.MIN_VALUE;
        long Small = Long.MAX_VALUE;

        System.out.println("Type Done To Get Results");
        while (true) {
            System.out.println("Enter a Number");
            final String Num = sc.next();
            if (Num.toLowerCase().equals("done")) {
                break;
            }
            Count += 1;
            System.out.println(Count + " - " + Num);
            final long iNum = Long.parseLong(Num);
            Sum += iNum;
            Avg = Sum / Count;
            if (iNum > Big)
            {
                Big = iNum;
            }
            if (iNum < Small)
            {
                Small = iNum;
            }
        }
        System.out.println("The Count is - " + Count);
        System.out.println("The Sum is - " + Sum);
        System.out.println("The Average is - " + Avg);
        System.out.println("The Biggest Number is - " + Big);
        System.out.println("The Smallest Number is - " + Small);

        System.out.println("\nType Anything To Quit");
        sc.next();
    }
        }
