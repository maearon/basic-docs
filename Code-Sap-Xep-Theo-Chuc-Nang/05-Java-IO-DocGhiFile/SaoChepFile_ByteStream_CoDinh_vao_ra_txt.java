import java.io.*;

public class LuongByte {  
public static void main(String args[]) throws IOException
{
	
FileInputStream fileInput = null;
 FileOutputStream fileOutput = null;

 try 
 {
	fileInput = new FileInputStream("E:\\vao.txt");
	fileOutput = new FileOutputStream("E:\\ra.txt");
	
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