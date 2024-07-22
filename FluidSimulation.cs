using System.Collections.Generic;

public class FluidSimulation 
{
    public List<Particle> Particles {get; private set;}

    public FluidSimulation(int particleCount)
    {
        Particles = new List<Particle>();
        InitialiseParticles(particleCount);
    }

    private void InitialiseParticles(int count)
    {
        var random = new Random();
        for(int i =0; i< count; i++)
        {
            var x = (float)random.NextDouble();
            var y = (float)random.NextDouble();
            Particles.Add(new Particle{X=x, Y=y});
        }
    }

    
    public void Update(float deltaTime)
    {
        
    }
    
}