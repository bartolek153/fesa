using Terminal.Gui;

namespace BatalhaNaval
{
    public class Design
    {
        public void FrontEnd(char[] tabuleiro)
        {

            // Console.SetWindowSize(70, 25);
            // Console.SetBufferSize(70, 25);

            Application.Init();

            Application.UseSystemConsole = true;

            var janelaPrincipal = new Window("Batalha Naval")
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill() - 1,
                ColorScheme = Colors.TopLevel,
                CanFocus = false
            };

            var statusBar = new StatusBar()
            {
                Visible = true,
                Items = new StatusItem[] {
                    new StatusItem(Key.q, "~q~ Sair do programa", () => { Application.RequestStop(); })
                }
            };

            var janelaTabuleiro = new Window("Tabuleiro")
            {
                X = Pos.Center(),
                Y = Pos.Center(),
                Height = 13,
                Width = 61,
                ColorScheme = Colors.TopLevel
            };


            string tabuleiroFormatado = "";

            for (int i = 0; i < tabuleiro.Length; i++)
            {
                tabuleiroFormatado += tabuleiro[i];

                if ((i + 1) % 10 == 0)
                    tabuleiroFormatado += "\n\n";
                else
                    tabuleiroFormatado += "     ";
            }

            var labelTabuleiro = new Label(tabuleiroFormatado)
            {
                X = 2,
                Y = 0,
                ColorScheme = new ColorScheme() { Normal = new Terminal.Gui.Attribute(Color.White, Color.Black) }
            };

            janelaTabuleiro.Add(labelTabuleiro);

            for (int h = 1; h < 10; h += 2)
                janelaTabuleiro.Add(new LineView() { Y = h });

            for (int v = 5; v < 55; v += 6)
                janelaTabuleiro.Add(new LineView(Terminal.Gui.Graphs.Orientation.Vertical) { X = v });


            string grupo = "Luiz Eduardo Kern Bartolassi 081220004\nLucas Kogima Morihara 081220043";
            janelaPrincipal.Add(new Label(grupo)
            {
                X = Pos.Center(),
                Y = 1,
            });


            Application.Top.Add(janelaPrincipal, janelaTabuleiro, statusBar);
            Application.Run();
            Application.Shutdown();
        }
    }
}
