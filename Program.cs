using SFML.Graphics;
using SFML.System;
using SFML.Window;



class Program
{
    const int WINDOW_WIDTH = 800;
    const int WINDOW_HEIGHT = 600;
    const float DELTA_TIME = 0.01f;

    const int NUM_OF_PARTICLES = 500;

    static void Main()
    {
        var window = new RenderWindow(new VideoMode(WINDOW_WIDTH, WINDOW_HEIGHT), "Fluid Simulation");
        window.Closed += (sender, e) => window.Close();

        var sim = new FluidSimulation(NUM_OF_PARTICLES);
        

        while(window.IsOpen)
        {
            window.DispatchEvents();

            sim.Update(DELTA_TIME);

            window.Clear(Color.White);

            foreach(var particle in sim.Particles)
            {
                var circle = new CircleShape(2){
                    Position = new Vector2f(x: particle.X*WINDOW_WIDTH, y: particle.Y*WINDOW_HEIGHT),
                    FillColor = Color.Blue
                };
                window.Draw(circle);
            }
            window.Display();
        }
    }
}