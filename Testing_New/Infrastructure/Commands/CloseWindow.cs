using System.Windows;
using Testing_New.Infrastructure.Commands.Base;

namespace Testing_New.Infrastructure.Commands
{
    internal class CloseWindow : Command
    {
        private static Window? GetWindow(object? p) => (p as Window ?? App.FocusedWindow ?? App.ActivedWindow) as Window;

        protected override bool CanExecute(object? p) => GetWindow(p) != null;

        protected override void Execute(object? p) => GetWindow(p)?.Close();

    }
}
