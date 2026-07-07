import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;


public class StringFinder {

public static void main(String[] args)
{
    double count = 0,countBuffer=0,countLine=0;
    String lineNumber = "";
    String filePath = "C:\\Users\\manh1\\Desktop\\Test.txt";
    BufferedReader br;
	String inputSearch;
	Scanner s = new Scanner(System.in);
	System.out.print("\tTen tep vao: ");
    inputSearch = s.nextLine();
    String line = "";

    try {
        br = new BufferedReader(new FileReader(filePath));
        try {
            while((line = br.readLine()) != null)
            {
                countLine++;
                //System.out.println(line);
                String[] words = line.split("\\w+");

                for (String word : words) {
                  if (word.equals(inputSearch)) {
                    count++;
                    countBuffer++;
                  }
                }

                if(countBuffer > 0)
                {
                    countBuffer = 0;
                    lineNumber += countLine + ",";
                }

            }
            br.close();
        } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    } catch (FileNotFoundException e) {
        // TODO Auto-generated catch block
        e.printStackTrace();
    }

    System.out.println("Times found at--"+count);
    System.out.println("Word found at--"+lineNumber);
}
}