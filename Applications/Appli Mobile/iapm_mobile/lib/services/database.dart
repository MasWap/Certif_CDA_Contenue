import 'package:mysql1/mysql1.dart';

class DatabaseConnection {
  static late MySqlConnection _connection;

  static MySqlConnection get connection => _connection;

  static Future<void> connect(ConnectionSettings settings) async {
    _connection = await MySqlConnection.connect(settings);
  }

  static Future<void> disconnect() async {
    await _connection.close();
  }
}
