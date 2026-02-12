import 'package:flutter/material.dart';
// statique 1 etat: StateLessWidget => stl
// Dynamique N Etat: StateFulWidget => stf

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
            InkWell(
              child: Icon(Icons.thumb_up, color: Colors.blue, size: 80),
              onTap: () {},
            ),
            Text("0", style: TextStyle(fontSize: 40)),
            InkWell(
              child: Icon(Icons.thumb_down, color: Colors.red, size: 80),
              onTap: () {},
            ),
          ],
        ),
      ),
    ),
  );
  runApp(myApp);
}
