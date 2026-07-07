import java.awt.*;
class Checkboxtest extends Frame
{
	Label l1 =new Label("Checkboxs");
	Checkbox b1=new Checkbox("red",true);
	Checkbox b2=new Checkbox("green",false);
	Checkbox b3=new Checkbox("blue",false);
	Label l2 =new Label("Radiobuttons");
	CheckboxGroup cb=new CheckboxGroup();
	Checkbox b4=new Checkbox("small",cb,true);
	Checkbox b5=new Checkbox("medium",cb,false);
	Checkbox b6=new Checkbox("large",cb,false);
	public Checkboxtest(String title)
	{
		super(title);
		setLayout(new GridLayout(8,1));
		add(l1);
		add(b1);
		add(b2);
		add(b3);
		add(l2);
		add(b4);
		add(b5);
		add(b6);
	}
	public static void main(String args[])
	{
		Checkboxtest t=new Checkboxtest("Checkbox and radiobuttons");
		t.setSize(300,200);
		t.show();
	}
}