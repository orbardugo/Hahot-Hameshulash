import java.util.Date;

public class Person {
	private int id;
	private String firstName;
	private String lastName;
	private int yearOfBirth;
	private String gender;

public Person(Object array[],int row)
{
	this.id=row;
	this.firstName=(String) array[0];
	this.lastName=(String) array[1];
	this.yearOfBirth=(int) array[2];
}

public int getId() {
	return id;
}

public String getFirstName() {
	return firstName;
}

public String getLastName() {
	return lastName;
}

public int getYearOfBirth() {
	return yearOfBirth;
}

public String toString(){
	return "Name: " + this.firstName + " " +this.lastName + " Birth Day: " + this.yearOfBirth;
}
}