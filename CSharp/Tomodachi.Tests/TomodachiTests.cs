using Xunit;
using Tomodachi;

namespace Tomodachi.Tests;

public class TomodachiTests
{
    [Fact]
    public void Pet_Initialization_SetsDefaultValues()
    {
        Pet pet = new("Tama");
        
        Assert.Equal("Tama", pet.Name);
        Assert.Equal(50, pet.Hunger);
        Assert.Equal(50, pet.Happiness);
        Assert.Equal(50, pet.Energy);
        Assert.False(pet.IsSleeping);
        Assert.False(pet.IsDead);
    }

    [Fact]
    public void Feed_DecreasesHunger_And_IncreasesHappiness()
    {
        Pet pet = new("Tama"); // Hunger: 50, Happiness: 50
        
        pet.Feed(20);
        
        Assert.Equal(30, pet.Hunger);
        Assert.Equal(55, pet.Happiness);
    }

    [Fact]
    public void Play_IncreasesHappiness_DecreasesEnergy_IncreasesHunger()
    {
        Pet pet = new("Tama"); // Happiness: 50, Energy: 50, Hunger: 50
        
        pet.Play();
        
        Assert.Equal(65, pet.Happiness);
        Assert.Equal(35, pet.Energy);
        Assert.Equal(60, pet.Hunger);
    }

    [Fact]
    public void Sleep_TogglesIsSleeping_And_TickRestoresEnergy()
    {
        Pet pet = new("Tama") { Energy = 20 };
        
        pet.Sleep();
        Assert.True(pet.IsSleeping);
        
        pet.Tick();
        Assert.Equal(40, pet.Energy);
    }

    [Fact]
    public void Feed_ThrowsException_ForInvalidPortion()
    {
        Pet pet = new("Tama");
        
        Assert.Throws<ArgumentOutOfRangeException>(() => pet.Feed(-10));
        Assert.Throws<ArgumentOutOfRangeException>(() => pet.Feed(0));
    }
}
