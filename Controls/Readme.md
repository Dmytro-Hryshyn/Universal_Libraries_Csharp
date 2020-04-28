# Custom controls

- [Sub Menu Control file](/Controls/SubMenuControl.cs)

# Sub menu control
<image src="https://github.com/Dmytro-Hryshyn/Universal_Libraries_Csharp/blob/master/Image/Side%20Menu/Side%20bar%20closed.png" width=400>  <image src="https://github.com/Dmytro-Hryshyn/Universal_Libraries_Csharp/blob/master/Image/Side%20Menu/Side%20bar%20open.png" width=400>

#### Main components:

1. Perent button (Unit_Converter_Btn) Button class
2. Sub menu panel (Unit_Converter_SubPanel) Panel class
3. Child buttons (Speed_btn) Button Clas
4. Child form (Speed_Formm) Windows Forms
5. Child form panel (ChildFormPanel) Panel class

To implement this control needs to create new instance of SubMenuControl Class. It takes two params Perent Button and SubMenu Panel as arguments. And calling OpenchildForm on child button click.

`OpenChildForm (new [Your forms name], Panel[were to open your Form])`

```
SubMenuControl unitConverter = new SubMenuControl (Unit_Converter_Btn, Unit_Converter_SubPanel);

Speed_Btn.Click += (sender, EventArgs) => unitConverter.OpenChildForm (new SpeedForm(), ChildFormPanel);
```





