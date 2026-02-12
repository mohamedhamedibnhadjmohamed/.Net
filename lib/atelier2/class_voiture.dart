class Voiture {
  //attr+get/set+construct+Method
  String _mat = "er";
  int _puissance = 0;
  String _marque = "aa";
  //getter
  String get mat => _mat;
  int get puissance => _puissance;
  String get marque => _marque;
  //setters
  set mat(String m) => _mat = m;
  set puissance(int p) => _puissance = p;
  set marque(String m) => _marque = m;
  //constructeurs
  Voiture() {
    _marque = "";
    _puissance = 0;
    _mat = "";
  }
  Voiture.avecParam(String mat, int puissance, String marque) {
    _marque = marque;
    _puissance = puissance;
    _mat = mat;
  }
  Voiture.avecParamOpt(String mat, int puissance, String marque);
  Voiture.avecParamOptNomme({
    String mat = "",
    required int puissance,
    required String marque,
  });
}

void main() {
  var v = Voiture();
  var v1 = Voiture.avecParam("aa", 10, "aa");
  var v2 = Voiture.avecParamOpt("aa", 10, "aa");
  var v3 = Voiture.avecParamOptNomme(mat: "aa", puissance: 10, marque: "aa");
  var v4 = Voiture.avecParamOptNomme( puissance: 10,mat: "aa", marque: "aa");
}
//////////////////
///=> classe =>Majus
/// attbit attbut nomme => mins
MaterialApp : configuration APP:
    theme,menu, routage, langue 
Scaffold : definuir le contenu d'un screen
   AppBar
  => Widget Imbriuqé
  Pere => Fils => N fils
       => child: => children