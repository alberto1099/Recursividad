import java.util.Scanner;

Public class Hanoi {



    public static void main(String[] args) {
        Scanner leer = new Scanner(System.in);

        System.out.println(" Con cuantos discos quieres jugar?");
        int discos = leer.nexInt();
        jannui(discos, 1, 2, 3);
        int movimientos = (int) (Math.pow(2, discos) - 1);
        System.out.println("El numero minimo de movimientos para" + discos + " discos es " + movimientos + " movimientos.");
    }

    public static void jannui(int discos, int inicio, int auxiliar, int destino) {

        if (discos == 1) {
            System.out.println("Movimiento de la torre " + inicio + " a la torre " + destino);
        } else {
            jannui(discos - 1, inicio, destino, auxiliar);
            System.out.println("Movimiento de la torre " + inicio + " a la torre " + destino);
            jannui(discos - 1, auxiliar, inicio, destino);
        }
    }

}