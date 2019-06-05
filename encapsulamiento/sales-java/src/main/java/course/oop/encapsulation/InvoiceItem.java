package course.oop.encapsulation;

import java.math.BigDecimal;

/**
 * Visibilidad privada de paquete (package-private).
 *
 * Esta clase no puede ser vista desde otros paquetes.
 * */
class InvoiceItem {

    private String productName;
    private BigDecimal amount;

    public InvoiceItem(String productName, BigDecimal amount) {
        this.productName = productName;
        this.amount = amount;
    }

    public BigDecimal getAmount() {
        return amount;
    }
}
