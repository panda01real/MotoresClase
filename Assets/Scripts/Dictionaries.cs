using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    Dictionary<ItemType, int> _inventory = new Dictionary<ItemType, int>();

    private Dictionary<ItemType, Item> _data = new Dictionary<ItemType, Item>()
    {
        { ItemType.Piedra, new Piedra() },
        { ItemType.Arena, new Arena() },
        { ItemType.Madera, new Madera() }
    };

    private void Start()
    {
        _data.Add(ItemType.Piedra, new Piedra());
        _data[ItemType.Piedra].Use();
        
        if (_inventory.ContainsKey(ItemType.Piedra))
        {
            _inventory[ItemType.Piedra] += 10;
        }
        else
        {
            _inventory.Add(ItemType.Piedra, 10);
        }
        _inventory.Remove(ItemType.Piedra);
        
        Debug.Log(_inventory[ItemType.Piedra]);
    }
}

public class Item
{
    public void Use()
    {
        
    }
}

public class Piedra : Item
{
    
}

public class Arena : Item
{
    
}

public class Madera : Item
{
    
}

enum ItemType
{
    Piedra,
    Madera,
    Arena
}

// un sistema primitivo e incompleto de inventario con diccionarios, interesante...
// .ContainsKey() devuelve bool, checkea la key del diccionario
// .ContainsValue() devuelve bool, checkea si existe el value en el diccionario
