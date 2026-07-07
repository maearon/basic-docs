import java.io.*;
import java.util.Scanner;

public class LuongByte {  
public static void main(String args[]) throws IOException
{

FileInputStream fileInput = null;
 FileOutputStream fileOutput = null;
 
 
 try 
 {
	int a,b;
	Scanner s = new Scanner(System.in);
	System.out.print("\tTen tep vao: ");
    a = s.nextInt();
	System.out.print("\n");
    System.out.print("\tTen tep ra: ");
    b = s.nextInt();
	System.out.print("\n");
	System.out.print("\tNhap du lieu tu tep E:\\"+a+".txt sao chep vao tep E:\\"+b+".txt");
	System.out.print("\n");
	fileInput = new FileInputStream("E:\\"+a+".txt");
	fileOutput = new FileOutputStream("E:\\"+b+".txt");
	
	
	int data;
	while ((data = fileInput.read()) != -1) 
		{
			
			fileOutput.write(data);
		}
 
 }
 
 catch (IOException e)
 {
 System.out.println("Error message: " + e.getMessage());
 } 
 
 finally 
 {
 if (fileInput != null)
 {
 fileInput.close();
 }
 if (fileInput != null)
 {
 fileOutput.close();
 }

 } 

}
} 