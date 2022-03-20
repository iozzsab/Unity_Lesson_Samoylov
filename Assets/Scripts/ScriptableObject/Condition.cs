using UnityEngine;

[CreateAssetMenu (menuName = ("Condition"))]
public class Condition :  RessetableScriptableObject
{
    public string description = "New Description";
    public virtual bool isSatisfied {get;  set;} = false;

    public override void Reset()
    {
        isSatisfied = false;
    }
    public virtual void Satisfy()
    {
        isSatisfied = true;
    }


}
