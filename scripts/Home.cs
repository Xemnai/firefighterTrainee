using Godot;
using Godot.Collections;
public class Home : Node2D
{
    [Export] private NodePath _addTraineePopupMenuPath;
    [Export] private NodePath _firstNameLineEditPath;
    [Export] private NodePath _lastNameLineEditPath;
    [Export] private NodePath _traineeNameLabelPath;
    [Export] private NodePath _traineeNameLabelPath2;
    [Export] private NodePath _traineeNameLabelPath3;
    [Export] private NodePath _traineeNameLabelPath4;
    [Export] private NodePath _traineeNameLabelPath5;
    [Export] private NodePath _traineeNameLabelPath6;
    [Export] private NodePath _traineeNameLabelPath7;

    private PopupMenu _addTraineePopup;
    private TextEdit _textEdit;
    private PopupMenu _addTraineePopupMenu;
    private Array<Trainee> _trainees = new Array<Trainee>();
    private LineEdit _firstNameLineEdit;
    private LineEdit _lastNameLineEdit;
    private Label _traineeNameLabel;
    private Label _traineeNameLabel2;
    private Label _traineeNameLabel3;
    private Label _traineeNameLabel4;
    private Label _traineeNameLabel5;
    private Label _traineeNameLabel6;
    private Label _traineeNameLabel7;
    private int numberLine = 1;

    private int line = 0;
    public override void _Ready()
    {
        _addTraineePopupMenu = GetNode<PopupMenu>(_addTraineePopupMenuPath);
        _firstNameLineEdit = GetNode<LineEdit>(_firstNameLineEditPath);
        _lastNameLineEdit = GetNode<LineEdit>(_lastNameLineEditPath);
        _traineeNameLabel = GetNode<Label>(_traineeNameLabelPath);
        _traineeNameLabel2 = GetNode<Label>(_traineeNameLabelPath2);
        _traineeNameLabel3 = GetNode<Label>(_traineeNameLabelPath3);
        _traineeNameLabel4 = GetNode<Label>(_traineeNameLabelPath4);
        _traineeNameLabel5 = GetNode<Label>(_traineeNameLabelPath5);
        _traineeNameLabel6 = GetNode<Label>(_traineeNameLabelPath6);
        _traineeNameLabel7 = GetNode<Label>(_traineeNameLabelPath7);
    }

    public void _on_AddTraineeButton_pressed()
    {
        _addTraineePopupMenu.PopupCentered();
    }

    public void _on_ValidateButton_pressed()
    {
        if (_trainees.Count != 0)
            if (_trainees.Count % 4 == 0)
                numberLine++;
        _lastNameLineEdit = (LineEdit)GetNode("AddTraineePopupMenu/NameLineEdit");

        Trainee trainee = new Trainee(_firstNameLineEdit.Text, _lastNameLineEdit.Text);
        _trainees.Add(trainee);

        switch (numberLine)
        {
            case 1:
                _traineeNameLabel.Text += _firstNameLineEdit.Text + " " + _lastNameLineEdit.Text + " - ";
                break;
            case 2:
                _traineeNameLabel2.Text += _firstNameLineEdit.Text + " " + _lastNameLineEdit.Text + " - ";
                break;
            case 3:
                _traineeNameLabel3.Text += _firstNameLineEdit.Text + " " + _lastNameLineEdit.Text + " - ";
                break;
            case 4:
                _traineeNameLabel4.Text += _firstNameLineEdit.Text + " " + _lastNameLineEdit.Text + " - ";
                break;
            case 5:
                _traineeNameLabel5.Text += _firstNameLineEdit.Text + " " + _lastNameLineEdit.Text + " - ";
                break;
            case 6:
                _traineeNameLabel6.Text += _firstNameLineEdit.Text + " " + _lastNameLineEdit.Text + " - ";
                break;
            case 7:
                _traineeNameLabel7.Text += _firstNameLineEdit.Text + " " + _lastNameLineEdit.Text + " - ";
                break;
        }

        _addTraineePopupMenu.Hide();
        _firstNameLineEdit.Text = "";
        _lastNameLineEdit.Text = "";
    }
}

