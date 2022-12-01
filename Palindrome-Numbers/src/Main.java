import java.util.Scanner;
public class Main {
    public static boolean isPalindrome(int number){
        int temp = number, lastNumber, reverseNumber = 0;
        while(temp != 0)
        {
            lastNumber = temp % 10;
            reverseNumber = (reverseNumber * 10) + lastNumber;
            temp = temp / 10;
        }

        if(number == reverseNumber)
            return true;
        else{
            return false;
        }
    }

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int i = 1;
        do {
            System.out.print("Enter the Number: ");
            int number = input.nextInt();
            if (isPalindrome(number) == true) {
                System.out.println(number + " is Palindrome Number!");
            }
            else {
                System.out.println(number + " is not Palindrome Number :(");
            }
        }
        while(i != 0);

    }
}