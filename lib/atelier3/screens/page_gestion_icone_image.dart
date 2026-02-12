import 'package:flutter/material.dart';

class GestionIcones extends StatefulWidget {
  const GestionIcones({super.key});

  @override
  State<GestionIcones> createState() => _MyWidgetState();
}

class _MyWidgetState extends State<GestionIcones> {
  List<IconData> listeIcones = [
    Icons.ac_unit_sharp,
    Icons.accessibility,
    Icons.accessible_forward_rounded,
  ];
  int index = 0;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Gestion Icone & Image"),
        backgroundColor: Colors.amber,
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Icon(listeIcones[index], size: 60),
                ElevatedButton(
                  onPressed: () {
                    setState(() {
                      if (index < listeIcones.length - 1)
                        index++;
                      else
                        index = 0;
                    });
                  },
                  child: Text("Changer Icone"),
                ),
              ],
            ),
            Column(children: []),
          ],
        ),
      ),
    );
  }
}
