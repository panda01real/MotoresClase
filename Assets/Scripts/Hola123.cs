using UnityEngine;

public class Hola123
{
    /* ------------------------------------------
     *          CLASE POST PARCIAL
     * ------------------------------------------
     *
     *  -Delegate
     *  Es una forma de coleccionar metodos!
     *  Sirve para separar responsabilidades, para eventos
     */
    
    //  Ejemplo
    public delegate int MiDelegate();

    public delegate void OnGetDamage(int damage);
    
    /*  Los metodos se pueden suscribir a los delegate, con +=,
     *  Y des suscribir con -=. Tambien se pueden igualar?, con =
     * 
     */
}
