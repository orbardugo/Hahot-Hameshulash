
public class TestOutil  
{
    public static void main(String[] args) throws Exception 
    {
        Tableau tab = new Tableau("C:/Users/Ruben/Desktop/a.xlsx", "sheet1");
        Object corps[][] = tab.getBody();
        Person[] persons=new Person[corps.length];
        for (int i = 0; i < corps.length; i++) {
        	persons[i]=new Person(corps[i],i);
        	persons[i].printPerson();
		}
        
        //System.out.println(corps[0][0]);
     /*   corps[1][0] = 5000;
        Object corps2[][] = tab.getBody();
        System.out.println(corps2[1][0]);
        tab.save();*/
    }
}