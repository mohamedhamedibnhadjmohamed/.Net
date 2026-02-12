import 'package:flutter/material.dart';

class Compteur extends StatefulWidget {
  const Compteur({super.key});

  @override
  State<Compteur> createState() => _MyWidgetState();
}

class _MyWidgetState extends State<Compteur> {
  int cpt = 0;
  Color couleur = Colors.yellow;
  incrementer() {
    setState(() {
      print("Click sur UP");
      cpt += 1;
      print("Cpt=$cpt");
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: couleur,
      appBar: AppBar(
        title: Text("Exercice 01", style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue[400],
        centerTitle: true,
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                InkWell(
                  child: Icon(Icons.thumb_up, color: Colors.blue, size: 80),
                  onTap: () {
                    incrementer();
                  },
                ),
                Text(cpt.toString(), style: TextStyle(fontSize: 40)),
                InkWell(
                  child: Icon(Icons.thumb_down, color: Colors.red, size: 80),
                  onTap: () {
                    setState(() {
                      print("Click sur DOWN");
                      cpt -= 1;
                      print("Cpt=$cpt");
                    });
                  },
                ),
              ],
            ),
            ElevatedButton(
              onPressed: () {
                setState(() {
                  if (couleur == Colors.yellow)
                    couleur = Colors.green;
                  else
                    couleur = Colors.yellow;
                });
              },
              child: Text("Changer Couleur"),
            ),
          ],
        ),
      ),
    );
  }
}
