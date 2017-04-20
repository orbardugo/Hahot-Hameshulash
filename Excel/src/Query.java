import java.util.Date;

public class Query {
	private int id;
	private String Query;
	private int amount;
	private Date from,to;
	
	public Query(){
		
	}

	public int getId() {
		return id;
	}

	public String getQuery() {
		return Query;
	}

	public int getAmount() {
		return amount;
	}

	public void setId(int id) {
		this.id = id;
	}

	public void setQuery(String query) {
		Query = query;
	}

	public void setAmount(int amount) {
		this.amount = amount;
	}
}
