
public class Card 
{
    private float happiness;
    private float money;
    private float health;
    private float education;
    private int realMoney;
    public Card(float happiness,float money, float health, float education, int realMoney)
    {
        this.money =     money;
        this.health =    health;
        this.education = education;
        this.happiness = happiness;
        this.realMoney = realMoney;
    }

    public Card()
    {
        this.money = 0;
        this.health = 0;
        this.education = 0;
        this.happiness = 0;
        this.realMoney = 0;
    }
    public float getHappiness()
    {
        return happiness;
    }

    public float getMoney()
    {
        return money;
    }
    
    public float getHealth()
    {
        return health;
    }

    public float getEducation()
    {
        return education;
    }

    public int getRealMoney()
    {
        return realMoney;
    }
}
