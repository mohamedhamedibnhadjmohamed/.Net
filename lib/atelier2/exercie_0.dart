import 'package:flutter/material.dart';

void main() {
  var myApp = MaterialApp(
    home: Scaffold(
      appBar: AppBar(
        title: Text("First Page", style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue[400],
        centerTitle: true,
      ),
      body: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          Center(
            child: Text(
              "Bonjour",
              style: TextStyle(fontSize: 40, color: Colors.red),
            ),
          ),
          Center(
            child: Text(
              "DSI G2",
              style: TextStyle(fontSize: 40, color: Colors.red),
            ),
          ),
        ],
      ),
    ),
  );
  runApp(myApp);
}
