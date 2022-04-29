// See https://aka.ms/new-console-template for more information

using System;
using Command;

Document document = new Document();
ICommand openCommand = new OpenCommand(document);
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);
MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
menu.clickOpen();
menu.clickSave();
menu.clickClose();
Console.ReadKey();