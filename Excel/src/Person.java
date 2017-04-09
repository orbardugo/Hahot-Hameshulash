import java.util.Date;

public class Person {
	private int id;
	private String firstName;
	private String lastName;
	private String gender;
	private int age;
	private String currentOccupation;
	private String useOfAlcohol;
	private String useOfDrugs;
	private String prostitution;
	private String criminalRecord;
	private int numOfInstitutions;
	private String commWithOtherInstitution;
	private String cityOfOrigin;
	private int yearOfBirth;
	private String gender;

	public Person(Object array[],int row)
	{
		this.id=row;
		this.firstName=(String) array[0];
		this.lastName=(String) array[1];
		this.yearOfBirth=(int) array[2];
		this.age = (int) array[3];
		this.gender = (String) array[4];
		this.currentOccupation = (String) array[5];
		this.useOfAlcohol = (String) array[6];
		this.useOfDrugs = (String) array[7];
		this.prostitution = (String) array[8];
		this.criminalRecord = (String) array[9];
		this.numOfInstitutions = (int) array[10];
		this.commWithOtherInstitution = (String) array[11];
		this.cityOfOrigin = (String) array[12];

	}

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public String getCurrentOccupation() {
		return currentOccupation;
	}

	public void setCurrentOccupation(String currentOccupation) {
		this.currentOccupation = currentOccupation;
	}

	public String getUseOfAlcohol() {
		return useOfAlcohol;
	}

	public void setUseOfAlcohol(String useOfAlcohol) {
		this.useOfAlcohol = useOfAlcohol;
	}

	public String getUseOfDrugs() {
		return useOfDrugs;
	}

	public void setUseOfDrugs(String useOfDrugs) {
		this.useOfDrugs = useOfDrugs;
	}

	public String getProstitution() {
		return prostitution;
	}

	public void setProstitution(String prostitution) {
		this.prostitution = prostitution;
	}

	public String getCriminalRecord() {
		return criminalRecord;
	}

	public void setCriminalRecord(String criminalRecord) {
		this.criminalRecord = criminalRecord;
	}

	public int getNumOfInstitutions() {
		return numOfInstitutions;
	}

	public void setNumOfInstitutions(int numOfInstitutions) {
		this.numOfInstitutions = numOfInstitutions;
	}

	public String getCommWithOtherInstitution() {
		return commWithOtherInstitution;
	}

	public void setCommWithOtherInstitution(String commWithOtherInstitution) {
		this.commWithOtherInstitution = commWithOtherInstitution;
	}

	public String getCityOfOrigin() {
		return cityOfOrigin;
	}

	public void setCityOfOrigin(String cityOfOrigin) {
		this.cityOfOrigin = cityOfOrigin;
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
