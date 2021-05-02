using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ViewContentElement 
{
    void jumpTo(int index);

    List<string> getNameList();
}
