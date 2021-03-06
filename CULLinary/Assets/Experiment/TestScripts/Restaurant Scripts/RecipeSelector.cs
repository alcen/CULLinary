using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Deals with any of the buttons that can be clicked in the Menu Panel
public class RecipeSelector : MonoBehaviour
{
    public CookingStation cookingStation;
    public UIController uiController;
    public InventoryUI inventory;
    public UIRecipeBook recipeBook;

    // Closes the UI panel 
    public void SelectCloseButton()
    {
        uiController.CloseCookingPanel();
    }

    // Closes the Menu panel and cooks food if there is enough space on the counter
    private void StartCooking(string dishName)
    {
        if (cookingStation.CheckAvailableSlots() == true)
        {
            Debug.Log("Selected: " + dishName);
            uiController.CloseCookingPanel(); // close the menu 
            cookingStation.Cook(dishName); // start cooking
        } else
        {
            uiController.ShowCounterNotifPanel(); //show UI notif that counter has no more space to place food
        }
    }

    // Methods to trigger when player clicks on the relevant button
    // May need to abstract out more if we intend to spawn new recipe buttons (>4 recipes than the ones we currently have) dynamically...? 
    // or maybe just pre-make them and save them as prefabs, then spawn them dynamically? --> KIV first
    public void SelectEggplant()
    {
        if (inventory.RemoveIdsFromInventory(Recipes.recipes[0].getIngredients())) {
            StartCooking("eggplant");
        } else {
            uiController.ShowNotEnoughIngredientsNotifPanel();
        }
    }

    public void SelectGoldEggplant()
    {   
        if (inventory.RemoveIdsFromInventory(Recipes.recipes[1].getIngredients())) {
            StartCooking("goldeggplant");     
        } else {
            uiController.ShowNotEnoughIngredientsNotifPanel();
        }
    }

    public void SelectPizza()
    {
        if (inventory.RemoveIdsFromInventory(Recipes.recipes[2].getIngredients())) {
            StartCooking("pizza");       
        } else {
            uiController.ShowNotEnoughIngredientsNotifPanel();
        }
    }

    public void SelectBurrito()
    {
        if (inventory.RemoveIdsFromInventory(Recipes.recipes[3].getIngredients())) {
            StartCooking("burrito");
        } else {
            uiController.ShowNotEnoughIngredientsNotifPanel();
        }
    }
}
