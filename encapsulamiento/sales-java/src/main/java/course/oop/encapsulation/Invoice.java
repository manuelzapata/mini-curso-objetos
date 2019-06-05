package course.oop.encapsulation;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;

/**
 * Clase pública. Puede ser accedida por cualquier clase en cualquier paquete.
 */
public class Invoice {

    /**
     * Esta atributo solo está disponible en esta clase.
     */
    private ArrayList<InvoiceItem> items;

    public Invoice() {
        items = new ArrayList<InvoiceItem>();
    }

    public void addItem(String productName, BigDecimal amount) {
        items.add(new InvoiceItem(productName, amount));
    }

    /**
     * Visibilidad privada de paquete (package-private).
     *
     * Este método no puede ser visto desde otros paquetes.
     * */
    void addItem(InvoiceItem item) {
        items.add(item);
    }

    /** Este método solo puede ser visto en el paquete y en clases hijas (así estén en otros paquetes). */
    protected BigDecimal calculateTotal() {

        BigDecimal result = new BigDecimal(0);

        for (InvoiceItem item: items) {
            result.add(item.getAmount());
        }

        return result;
    }


}
