$arg  = $_POST['arg'];

header('HTTP/1.1 201 Created');
echo json_encode($arg);
