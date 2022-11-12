// https://www.hackerrank.com/challenges/kaprekar-numbers/
import java.util.*;
public class Main {
    public static void kaprekarNumbers(int p, int q) {
        String kare="";
        String sag="";
        String sol="";
        int sonuc=0;
        List<Integer> list=new ArrayList<Integer>();
        for(int x=p;x<q;x++){

            kare=String.valueOf(x*x);

            if(x==1){
                list.add(x);
            }

            else if(x==9){
                list.add(x);
            }

            else if(kare.length()%2==0 && x>=32){
                int sayi=kare.length()/2;
                sol = kare.substring(0, sayi);
                sag =kare.substring(sayi);
                sonuc=Integer.parseInt(sag)+Integer.parseInt(sol);
                if(sonuc==x){
                    list.add(x);
                }
            }

            else if(x>=32){
                double sayi=Math.floor(kare.length()/2);
                int value = (int)sayi;
                sol = kare.substring(0, value);
                sag =kare.substring(value);
                sonuc=Integer.parseInt(sag)+Integer.parseInt(sol);
                if(sonuc==x){
                    list.add(x);
                }
            }
        }

        for (Integer i : list) {
            System.out.print(i+" ");
        }
    }

    public static void main(String[] args) {

        kaprekarNumbers(1,100);
    }
}