using Godot;
using System;

public partial class MainMenu : Node2D
{
    [Export] public Label myLabel;

    [Export] public eSceneNames mySceneName;
    private int count = 0;
    public override void _Ready()
    {
        myLabel.Text = "Changed the label on Ready in c# !";
    }

    public override void _Process(double delta)
    {
        
    }

    public void _on_button_1_button_up()
    {
        SceneManager.instance.ChangeScene(eSceneNames.Main);

        count++;
        myLabel.Text = "Button 1 was clicked! " + count;
    }
}
