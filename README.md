# BallisticCalculator

A new version of a ballistic calculator API, a new generation of a light-weight, LGPL library of modeling projectile trajectory in atmosphere

The library provides trajectory calculations for projectiles, including for various applications, including air rifles, bows, firearms, artillery, and so on.

3DF (degrees of freedom) model that is used in this calculator is rooted in [old C sources](http://www.jbmballistics.com/ballistics/downloads/downloads.shtml) of version 2 of the public version of the JBM calculator, ported to C#, optimized, fixed, and extended with elements described in Litz's "Applied Ballistics" book and ideas of the friendly project by Alexandre Trofimov.

Changes made since porting original C sources:

* "Deciphering" formulas and making them readable for anyone familiar with the school curriculum of physics.

* New drag calculation method with higher accuracy (40+ approximation points for calculating polynomial coefficients vs 5-6).

* New atmosphere parameters calculating basing on NASA formulas

* New algorithm of step size definition to find the right balance between performance and accuracy.

* Drift calculation is added using Liltz's formulas

* Accuracy of the calculation is withing 0.5%/0.2moa (less than 2inch per 1000 yards) of the most modern calculators.

Please refer to [online version of the documentation](http://docs.gehtsoftusa.com/BallisticCalculator1/)

If you want to use the latest official version of the package, use [Gehtsoft public nuget channel](https://www.myget.org/F/gehtsoft-public/api/v3/index.json)
or download package directly from releases here.

The library is also available in Go: https://github.com/gehtsoft-usa/go_ballisticcalc

For those who are looking for a JavaScript version, I highly recommend [Yet Another Ballistic Calculator](https://ptosis.ch/ebalka/ebalka.html) project of our friend Alexandre Trofimov.

The current status of the project is ALPHA version.

RISK NOTICE

The library performs very limited simulation of a complex physical process and so it performs a lot
of approximations. Therefore the calculation results MUST NOT be considered as completely and reliably
reflecting actual behavior or characteristics of projectiles. While these results may be used for
educational purpose, they must NOT be considered as reliable for the areas where incorrect calculation may
cause making a wrong decision, financial harm, or can put a human life at risk.

THE CODE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE MATERIALS OR THE USE OR OTHER DEALINGS IN THE MATERIALS.
