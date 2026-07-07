import java.io.*;
import java.util.Scanner;

public class temp {  
public static void main(String args[]) throws IOException
{

FileInputStream fileInput = null;
 FileOutputStream fileOutput = null;
 
 
 try 
 {
	
	
	FileReader fr = new FileReader("C:\\Users\\manh1\\Desktop\\test.txt");
	BufferedReader br = new BufferedReader(fr);
	
	BufferedReader a = new BufferedReader(new InputStreamReader(System.in));
	System.out.print("\tNhap dong van ban: ");
	
	String str;
	
	str=a.readLine();
	
	String k;
	
	while((k=br.readLine()) != null)
	{
		if (k.equals(str)) 
		{
		System.out.println(k);
		}
		
			
	}
	/*
	fileInput = new FileInputStream("C:\\Users\\manh1\\Desktop\\test.txt");
	
	fileOutput = new FileOutputStream(b);
	
	
	int data;
	do
	{
		data = fileInput.read(); 
		if(data != -1) System.out.print((char) data);
	} while (data != -1);
	*/
 }
 
 catch (IOException e)
 {
 System.out.println("Thong bao loi: " + e.getMessage());
 } 
 
 finally 
 {
 if (fileInput != null)
 {
 fileInput.close();
 }
 /*
 if (fileInput != null)
 {
 fileOutput.close();
 }
*/
 } 

}
} 