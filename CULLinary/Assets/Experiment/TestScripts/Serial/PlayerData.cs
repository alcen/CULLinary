using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string inventory;
    public int currentIndex; //references whether we are in the rest/dungeon
    public string playerName;
    public int money;
    public int maxHealth;
    public int currentHealth;
    public int rangeDamage;
    public int meleeDamage;
    public float critRate;
    public bool[] weaponsBought;
    public bool[] keyItemsBought;
    public int noOfMobsCulled;
    public int wrongCustomersServed;
    public int rightCustomersServed;

    public float gameTime;

    public float bossTime;

    public PlayerData()
    {
        this.inventory = "";
        this.money = 0;
        this.currentIndex = (int)SceneIndexes.TUT_REST;
        this.playerName = "John Doe";
        this.maxHealth = 100;
        this.currentHealth = 100;
        this.rangeDamage = 20;
        this.meleeDamage = 20;
        this.critRate = 0f;
        this.wrongCustomersServed = 0;
        this.rightCustomersServed = 0;
        this.weaponsBought = new bool[50];
        this.keyItemsBought = new bool[50];
        this.noOfMobsCulled = 0;
        this.gameTime = 0f;
        this.bossTime = 0f;
        for (int i = 0; i < this.weaponsBought.Length; i++)
        {
            this.weaponsBought[i] = false;
            this.keyItemsBought[i] = false;
        }
    }

    public float GetGameTime()
    {
        return this.gameTime;
    }

    public float GetBossTime()
    {
        return this.bossTime;
    }

    public int GetRightCustomersServed()
    {
        return this.rightCustomersServed;
    }

    public int GetWrongCustomersServed()
    {
        return this.wrongCustomersServed;
    }

    public float GetCritRate()
    {
        return this.critRate;
    }

    public bool GetIfKeyItemBoughtById(int id)
    {
        return this.keyItemsBought[id];
    }

    public bool GetIfWeaponBoughtById(int id)
    {
        return this.weaponsBought[id];
    }

    public string GetInventoryString()
    {
        return this.inventory;
    }

    public int GetCurrentIndex()
    {
        return this.currentIndex;
    }

    public string GetPlayerName()
    {
        return this.playerName;
    }

    public int GetMoney()
    {
        return this.money;
    }

    public int GetMaxHealth()
    {
        return this.maxHealth;
    }

    public int GetCurrentHealth()
    {
        return this.currentHealth;
    }

    public int GetRangeDamage()
    {
        return this.rangeDamage;
    }
    
    public int GetMeleeDamage()
    {
        return this.meleeDamage;
    }
    public int GetNoOfMobsCulled()
    {
        return this.noOfMobsCulled;
    }

    public void SetWrongCustomersServed(int i)
    {
        this.wrongCustomersServed = i;
    }

    public void SetRightCustomersServed(int i)
    {
        this.rightCustomersServed = i;
    }
    public void SetNoOfMobsCulled(int i)
    {
        this.noOfMobsCulled = i;
    }

    public void SetCritRate(float cr)
    {
        this.critRate = Mathf.Max(this.critRate, cr);
    }

    public void SetKeyItemBoughtById(int id, bool flag=true)
    {
        this.keyItemsBought[id] = flag;
    }

    public void SetWeaponBoughtById(int id, bool flag=true)
    {
        this.weaponsBought[id] = flag;
    }

    public void SetMeleeDamage(int dmg)
    {
        this.meleeDamage = dmg;
    }

    public void SetRangeDamage(int dmg)
    {
        this.rangeDamage = dmg;
    }

    public void SetInventoryString(string inventory)
    {
        this.inventory = inventory;
    }

    public void SetCurrentIndex(int currentIndex)
    {
        this.currentIndex = currentIndex;
    }

    public void SetPlayerName(string playerName)
    {
        this.playerName = playerName;
    }

    public void SetMoney(int money)
    {
        this.money = money;
    }

    public void SetMaxHealth(int maxHealth)
    {
        this.maxHealth = maxHealth;
    }

    public void SetGameTime(float i)
    {
        this.gameTime = i;
    }

    public void SetBossTime(float i)
    {
        this.bossTime = i;
    }

    public void SetCurrentHealth(int currentHealth)
    {
        this.currentHealth = Mathf.Min(currentHealth, this.maxHealth);
        //this.currentHealth = Mathf.Min(Mathf.Max(100, currentHealth),this.maxHealth); //Clamp
    }

    public string ToJson()
    {
        return JsonUtility.ToJson(this);
    }

    public void LoadFromJson(string jsonData)
    {
        try
        {
            JsonUtility.FromJsonOverwrite(jsonData, this);
        } 
        catch
        {
            Debug.Log("No save file...");
        }
    }

}