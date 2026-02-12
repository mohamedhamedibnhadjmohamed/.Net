import 'package:flutter/material.dart';

void main() {
  var myApp = MaterialApp(
    home: Scaffold(
      appBar: AppBar(
        title: Text("Exercice 01", style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue[400],
        centerTitle: true,
      ),
      body: Center(
        child: Row(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            monButon(
              traitement: () {
                print("Save in progress...");
              },
              texte: "Save",
              l: 160,
              h: 70,
            ),
            Icon(Icons.access_time_filled_sharp, color: Colors.amber, size: 80),
            monButon(
              traitement: () {
                print("Cancel...");
              },
              texte: "Cancel",
              l: 160,
              h: 70,
              couleur: Colors.red,
            ),
          ],
        ),
      ),
    ),
  );
  runApp(myApp);
}

Widget monButon({
  required void Function()? traitement,
  required String texte,
  required double h,
  required double l,
  Color couleur = Colors.green,
}) {
  return Padding(
    padding: const EdgeInsets.only(right: 10),
    child: SizedBox(
      height: h,
      width: l,
      child: ElevatedButton(
        onPressed: traitement,
        child: Text(texte),
        style: ElevatedButton.styleFrom(
          backgroundColor: couleur,
          foregroundColor: Colors.white,
          shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(0)),
        ),
      ),
    ),
  );
}
