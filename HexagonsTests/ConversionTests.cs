using NUnit.Framework;
using Zen.Hexagons;

namespace Zen.HexagonsTests
{
    public class ConversionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OffsetCoordinatesToCube_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var cube1 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-2, 3, -1), cube1);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube2);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube4);
            Assert.AreEqual(new HexCubeCoordinates(2, 1, -3), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube6);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube7);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube9);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube17);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube19);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-2, -1, 3), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-1, -2, 3), cube22);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(1, -3, 2), cube24);
            Assert.AreEqual(new HexCubeCoordinates(2, -3, 1), cube25);
        }

        [Test]
        public void OffsetCoordinatesToCube_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var cube1 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-2, 3, -1), cube1);
            Assert.AreEqual(new HexCubeCoordinates(-1, 3, -2), cube2);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(1, 2, -3), cube4);
            Assert.AreEqual(new HexCubeCoordinates(2, 1, -3), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube6);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube7);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube9);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube17);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube19);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-2, -1, 3), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube22);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube24);
            Assert.AreEqual(new HexCubeCoordinates(2, -3, 1), cube25);
        }

        [Test]
        public void OffsetCoordinatesToCube_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var cube1 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-1, 3, -2), cube1);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube2);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube4);
            Assert.AreEqual(new HexCubeCoordinates(3, -1, -2), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube6);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube7);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube9);
            Assert.AreEqual(new HexCubeCoordinates(3, -2, -1), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube17);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube19);
            Assert.AreEqual(new HexCubeCoordinates(2, -3, 1), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-3, 1, 2), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube22);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube24);
            Assert.AreEqual(new HexCubeCoordinates(1, -3, 2), cube25);
        }

        [Test]
        public void OffsetCoordinatesToCube_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var cube1 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-1, 3, -2), cube1);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube2);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube4);
            Assert.AreEqual(new HexCubeCoordinates(3, -1, -2), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-2, 3, -1), cube6);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube7);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube9);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-3, 2, 1), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube17);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube19);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-3, 1, 2), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube22);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube24);
            Assert.AreEqual(new HexCubeCoordinates(1, -3, 2), cube25);
        }

        [Test]
        public void OffsetCoordinatesToAxial_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var axial1 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-2, -1), axial1);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial2);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial4);
            Assert.AreEqual(new HexAxialCoordinates(2, -3), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial17);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial19);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-2, 3), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-1, 3), axial22);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(1, 2), axial24);
            Assert.AreEqual(new HexAxialCoordinates(2, 1), axial25);
        }

        [Test]
        public void OffsetCoordinatesToAxial_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var axial1 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-2, -1), axial1);
            Assert.AreEqual(new HexAxialCoordinates(-1, -2), axial2);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(1, -3), axial4);
            Assert.AreEqual(new HexAxialCoordinates(2, -3), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial19);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-2, 3), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial22);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial24);
            Assert.AreEqual(new HexAxialCoordinates(2, 1), axial25);
        }

        [Test]
        public void OffsetCoordinatesToAxial_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var axial1 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-1, -2), axial1);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial2);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial4);
            Assert.AreEqual(new HexAxialCoordinates(3, -2), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial6);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial9);
            Assert.AreEqual(new HexAxialCoordinates(3, -1), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial19);
            Assert.AreEqual(new HexAxialCoordinates(2, 1), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-3, 2), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial22);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial24);
            Assert.AreEqual(new HexAxialCoordinates(1, 2), axial25);
        }

        [Test]
        public void OffsetCoordinatesToAxial_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var axial1 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetCoordinatesToAxial(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-1, -2), axial1);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial2);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial4);
            Assert.AreEqual(new HexAxialCoordinates(3, -2), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-2, -1), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-3, 1), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial19);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-3, 2), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial22);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial24);
            Assert.AreEqual(new HexAxialCoordinates(1, 2), axial25);
        }
    }
}