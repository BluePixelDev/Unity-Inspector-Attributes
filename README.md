# Unity-Inspector-Attributes

A custom inspector attributes to make inspector variables more organized. 

## Attributes

List of attributes:
1. **Divider**
2. **Label**

## How to add
To add theese custom attributes into your project you must first download the *Attributes* folder and add it somewhere in your unity project. Now you should be able to write [*Atribute name*] to use the attribute. 

## 1. Divider
Draws a divider in the inspector window. You can aslo specify the height of the divider.

Usage:

- **[Divider]**
- **[Divider(float height)**

##### Example:
```
public float value1;
[Divider]
public float value2;
```
![Divider-Example](https://user-images.githubusercontent.com/78659109/160275364-9580e6f7-b39a-46b5-a949-a6f4dba63edb.png)

## 2. Label
Draws a simple label/text. You can specify the text and style of the label by using [GUIStyle](https://docs.unity3d.com/ScriptReference/GUIStyle.html)
>*Note:* Default font style is ***bold and italic*** and default font size is **10**.

Usage:

- **[Label(string content)]**
- **[Label(string content, GUIStyle style)**

##### Example:
```
[Label]
public float value2;
```

![Label-Example](https://user-images.githubusercontent.com/78659109/160278404-22eb3073-e1c7-417f-bdbe-3206ab344029.png)
