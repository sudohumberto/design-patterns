// Adapter
public class EuroAdapter : Currency {
    private Dollar dollar;

    public EuroAdapter(Dollar dollar) {
        this.dollar = dollar;
    }

    public double getAmount() {
        return dollar.getDollarAmount() * 0.85;
    }

}