using NUnit.Framework;
using RolePlay;

namespace RolePlay.Test
{
    [TestFixture]
    public class PersonajeTests
    {
        [Test]
        public void Atacar()
        {
            //la vida del objetivo debe disminuir después del ataque
            Personaje atacante = new Personaje("Guerrero1", 0, 100, "Guerrero", 20, 0);
            Personaje objetivo = new Personaje("Enemigo1", 0, 80, "Enemigo", 0, 0);
            int vidaInicialObjetivo = objetivo.Vida;

            atacante.Atacar(objetivo);
            
            Assert.IsTrue(objetivo.Vida < vidaInicialObjetivo);
        }

        [Test]
        public void Defensa()
        {
            // la resistencia del personaje debe aumentar después de defenderse
            Personaje personaje = new Personaje("Defensor1", 0, 80, "Defensor", 0, 5);
            int vidaInicialPersonaje = personaje.Vida;

            personaje.Defensa();

            Assert.IsTrue(personaje.Vida > vidaInicialPersonaje);
        }

    }

}