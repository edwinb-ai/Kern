package ProcesadorImagenes.controllers;

import javafx.fxml.FXML;
import javafx.event.Event;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.FileChooser;
import java.io.File;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

public class MenuController {

    @FXML
    private VBox Window;
    @FXML
    private HBox image_view;

    @FXML
    public void MenuTest (Event e) {
        // Implement a File Chooser
        FileChooser fileExplorer = new FileChooser();
        fileExplorer.setTitle("Choose an image");

        // Add some file extensions, mainly image ones
        fileExplorer.getExtensionFilters().addAll(
                new FileChooser.ExtensionFilter("Image Files", "*.png", "*.jpg", "*.gif")
        );

        // Grab the file
        File selectedFile = fileExplorer.showOpenDialog(Window.getScene().getWindow());

        // Create an image from it
        Image imageToWork = new Image("file:" + selectedFile.getAbsolutePath());
        ImageView imageWorkView = new ImageView(imageToWork);

        // Adjust the image and also cache it
        imageWorkView.setSmooth(true);
        imageWorkView.setPreserveRatio(true);
        imageWorkView.setCache(true);

        // Display it inside a HBox
        image_view.getChildren().add(imageWorkView);
    }
}
